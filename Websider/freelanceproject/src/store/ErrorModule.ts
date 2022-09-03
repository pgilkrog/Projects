import Vue from 'vue'
import { Module, VuexModule, Mutation, Action, getModule } from 'vuex-module-decorators'
import store from './index'
import firebase from '@/db'
const db = firebase.firestore().collection('errors')

@Module({
  dynamic: true,
  store,
  name: 'errorData',
  namespaced: true
})

class ErrorData extends VuexModule {
  _initialized = false

  // Actions
  @Action({ rawError: true })
  async init () {
    console.log('ERRORDATA INITIALIZED')
    this.context.commit('SET_INITIALIZED', true)
  }

  async sendError (error: any) {
    db.add(error)
  }

  @Mutation
  SET_INITIALIZED (val: boolean) {
    this._initialized = val
  }

  // Getters
  get initialized (): boolean {
    return this._initialized
  }
}

export const ErrorModule = getModule(ErrorData)
