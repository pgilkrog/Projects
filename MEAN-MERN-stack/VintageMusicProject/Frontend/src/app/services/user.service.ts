import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Router } from '@angular/router';
import { AuthData } from '../models/auth-data.model';
import { Subject } from 'rxjs';
import { map } from 'rxjs/operators';
import { User } from '../models/user.model';

const BACKEND_URL = environment.apiUrl + 'users';

@Injectable({providedIn: 'root'})

export class UserService {
  private token: string;
  private userId: string;
  private isAuthenticated = false;
  private authStatusListener = new Subject<boolean>();

  private user: User = new User();
  private userUpdated = new Subject<{user: User}>();

  constructor(private http: HttpClient, private router: Router) { }

  getAuthStatusListener() {
    return this.authStatusListener.asObservable();
  }

  getIsAuth() {
    return this.isAuthenticated;
  }

  createUser(userName: string, userEmail: string, userPassword: string) {
    const authData: AuthData = {name: userName, email: userEmail, password: userPassword };
    this.http.post<{token: string, id: string}>(BACKEND_URL, authData)
      .subscribe(responseData => {
        const token = responseData.token;
        const id = responseData.id;
        this.token = token;
        this.userId = id;

        if (token) {
          this.saveAuthData();
          this.router.navigate(['/Login']);
        }
      }, error => {
        this.authStatusListener.next(false);
      });
  }

  favoriteUser(musiciansId: string) {
    if (this.token) {
      const data = {
        musicianId: musiciansId,
        userId: this.userId
      };
      this.http.put<{ msg: string }>(BACKEND_URL + '/favorite', data).subscribe(response => {
        console.log(response.msg);
      });
    }
  }

  removeFavorite(musiciansId: string) {
    this.http.delete<{ msg: string }>(BACKEND_URL + '/favorite/' + this.userId + '/' + musiciansId).subscribe(response => {
      return response.msg;
    });
  }

  getUser() {
     return this.http.get<{ user: User }>('http://localhost:5000/api/auth/' + this.userId);
  }

  login(userEmail: string, userPassword: string) {
    const authData: AuthData = {name: '', email: userEmail, password: userPassword};
    this.http.post<{token: string, id: string}>('http://localhost:5000/api/auth', authData)
      .subscribe(responseData => {
        const token = responseData.token;
        const id = responseData.id;
        this.token = token;
        this.userId = id;
        this.authStatusListener.next(true);
        this.isAuthenticated = true;

        if (token) {
          this.saveAuthData();
          this.router.navigate(['/Home']);
        }
      }, error => {
        this.authStatusListener.next(false);
      });
  }

  logout() {
    this.authStatusListener.next(false);
    this.isAuthenticated = false;
    this.removeAuthData();
  }

  autoAuthUser() {
    const authInformation = this.getAuthData();
    if (!authInformation) {
      return;
    }
    this.token = authInformation.token;
    this.userId = authInformation.userId;
    this.isAuthenticated = true;
    this.authStatusListener.next(true);
  }

  private saveAuthData() {
    localStorage.setItem('token', this.token);
    localStorage.setItem('userId', this.userId);
  }

  private removeAuthData() {
    localStorage.removeItem('token');
    localStorage.removeItem('userId');
    this.router.navigate(['/']);
  }

  private getAuthData() {
    const token = localStorage.getItem('token');
    const userId = localStorage.getItem('userId');

    if (!token || !userId) {
      return;
    }

    return {
      token,
      userId
    };
  }
}
