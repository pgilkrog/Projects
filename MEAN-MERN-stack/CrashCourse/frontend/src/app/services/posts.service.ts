import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import {map} from 'rxjs/operators';

import { environment } from '../../environments/environment';
import { Post } from '../classes/post.model';
import { Router } from '@angular/router';

const BACKEND_URL = environment.apiUrl + '/posts/';

@Injectable({providedIn: 'root'})

export class PostsService {
  private posts: Post[] = [];
  private postsUpdated = new Subject<{posts: Post[], postCount: number}>();

  constructor(private http: HttpClient, private router: Router) { }

  getPosts(postsPerPage: number, currentPage: number) {
    const queryParams = `?pagesize=${postsPerPage}&page=${currentPage}`;

    this.http.get<{message: string, posts: any, maxPosts: number}>(
      BACKEND_URL + queryParams
      ).pipe(map((postData) => {
      return { posts: postData.posts.map(post => {
        return {
          title: post.title,
          content: post.content,
          id: post._id,
          imagePath: post.imagePath,
          creator: post.creator
        };
      }), maxPosts: postData.maxPosts};
    }))
    .subscribe(transformedPostData => {
      this.posts = transformedPostData.posts;
      this.postsUpdated.next({
        posts: [...this.posts],
        postCount: transformedPostData.maxPosts
      });
    });
  }

  addPost(postTitle: string, postContent: string, image: File) {
    const postData = new FormData();
    postData.append('title', postTitle);
    postData.append('content', postContent);
    postData.append('image', image, postTitle);

    this.http.post<{message: string, post: Post}>(BACKEND_URL, postData)
    .subscribe(responseData => {
      this.router.navigate(['/']);
    });
  }

  getPostUpdateListener() {
    return this.postsUpdated.asObservable();
  }

  getPost(id: string) {
    return this.http.get<{
      _id: string;
      title: string;
      content: string;
      imagePath: string;
      creator: string;
    }>(BACKEND_URL + id);
  }

  updatePost(postId: string, postTitle: string, postContent: string, postImage: File | string) {
    let postData: Post | FormData;
    if (typeof(postImage) === 'object') {
      postData = new FormData();
      postData.append('id', postId);
      postData.append('title', postTitle);
      postData.append('content', postContent);
      postData.append('image', postImage, postTitle);
    } else {
      postData = {
        id: postId,
        title: postTitle,
        content: postContent,
        imagePath: postImage,
        creator: null
      };
    }
    this.http.put(BACKEND_URL + postId, postData)
      .subscribe(response => {
        this.router.navigate(['/']);
      });
  }

  deletePost(postId: string) {
    return this.http.delete(BACKEND_URL + postId);
  }
}
