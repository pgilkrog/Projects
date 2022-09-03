import { ILoginInfo, IUserData } from '@/types/UserTypes'
import { Module, VuexModule, Mutation, Action, getModule } from 'vuex-module-decorators'
import store from './index'
import firebase from '@/db'

@Module({
  dynamic: true,
  store,
  name: 'authData',
  namespaced: true
})

class AuthData extends VuexModule {
  _initialized = false
  _userData: IUserData | undefined
  _users: IUserData[] = []

  // Actions
  @Action({ rawError: true })
  async init () {
    console.log('USERDATA INITIALIZED')
    this.context.commit('SET_INITIALIZED', true)
  }

  @Action({ rawError: true })
  async loginUser (loginInfo: ILoginInfo) {
    firebase
      .auth()
      .signInWithEmailAndPassword(loginInfo.email, loginInfo.password)
      .then(data => {
        console.log('loginData', data)
      })
      .catch(err => {
        // logError.add({ err })
        console.log(err)
      })
  }

  @Action({ rawError: true })
  async logoutUser () {
    firebase.auth().signOut()
  }

  @Action({ rawError: true })
  async createUser (userInfo: ILoginInfo) {
    firebase
      .auth()
      .createUserWithEmailAndPassword(userInfo.email, userInfo.password)
      .then(data => {
        firebase.firestore().collection('users').add({
          userId: data.user?.uid,
          name: '',
          title: '',
          phone: '',
          rating: 0,
          ratingAmount: 0,
          website: '',
          description: '',
          skills: [],
          image: '',
          ratings: []
        } as IUserData)
        console.log('USERCREATED', data.user)
      })
      .catch(err => {
        console.log(err)
      })
  }

  @Mutation
  SET_INITIALIZED (val: boolean) {
    this._initialized = val
  }

  // Getters
  get initialized (): boolean {
    return this._initialized
  }

  // state: {
  //   user: {
  //     loggedIn: false,
  //     data: null
  //   }
  // },
  // getters: {
  //   user (state) {
  //     return state.user
  //   }
  // },
  // mutations: {
  //   SET_LOGGED_IN (state, value) {
  //     state.user.loggedIn = value
  //   },
  //   SET_USER (state, data) {
  //     state.user.data = data
  //   }
  // },
  // actions: {
  //   fetchUser ({ commit }, user) {
  //     commit('SET_LOGGED_IN', user !== null)
  //     if (user) {
  //       commit('SET_USER', {
  //         email: user.email,
  //         userId: user.uid
  //       })
  //     } else {
  //       commit('SET_USER', null)
  //     }
  //   }
  // },
  // modules: {
  // }
}

export const AuthModule = getModule(AuthData)
