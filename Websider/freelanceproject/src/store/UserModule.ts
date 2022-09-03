import { IUserData } from '@/types/UserTypes'
import Vue from 'vue'
import { Module, VuexModule, Mutation, Action, getModule } from 'vuex-module-decorators'
import store from './index'
import firebase from '@/db'
const db = firebase.firestore().collection('users')

@Module({
  dynamic: true,
  store,
  name: 'userData',
  namespaced: true
})

class UserData extends VuexModule {
  _initialized = false
  _userData: IUserData | undefined
  _users: IUserData[] = []

  // Actions
  @Action({ rawError: true })
  async init () {
    console.log('USERDATA INITIALIZED')
    this.context.commit('SET_INITIALIZED', true)
    this.getAllUsers()
  }

  @Action({ rawError: true })
  async getUserInfo (userId: string | undefined) {
    if (userId !== undefined) {
      (await db.get()).docs.map(doc => {
        if (doc.data().userId === userId) {
          this.setUserInfo(doc.data() as IUserData)
        }
      })
    }
  }

  @Action({ rawError: true })
  async setUserInfo (user: IUserData | undefined) {
    console.log('CHECK', user)
    this.SET_USERDATA(user)
  }

  @Action({ rawError: true })
  async getAllUsers () {
    const temp: IUserData[] = [];
    (await db.get()).docs.map(doc =>
      temp.push(doc.data() as IUserData)
    )
    this.SET_USERS(temp)
  }

  @Mutation
  SET_INITIALIZED (val: boolean) {
    this._initialized = val
  }

  @Mutation
  SET_USERDATA (user: IUserData | undefined) {
    Vue.set(this, '_userData', user)
  }

  @Mutation
  SET_USERS (users: IUserData[] | undefined) {
    Vue.set(this, '_users', users)
  }

  // Getters
  get initialized (): boolean {
    return this._initialized
  }

  get userData (): IUserData | undefined {
    return this._userData
  }

  get isLoggedIn (): boolean {
    return (this._userData !== undefined && this._userData !== null)
  }

  get users (): IUserData[] | undefined {
    return this._users
  }
}

export const UserModule = getModule(UserData)
