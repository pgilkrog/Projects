import { IUserState } from '@/types/UserTypes'
import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

export interface IRootState {
  user: IUserState
}

export default new Vuex.Store<IRootState>({})
