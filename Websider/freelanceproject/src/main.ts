import Vue from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'
import '@/styles/main.sass'
import { BootstrapVue, BootstrapVueIcons } from 'bootstrap-vue'
import { firestorePlugin } from 'vuefire'

Vue.use(BootstrapVue)
Vue.use(BootstrapVueIcons)
Vue.use(firestorePlugin)

Vue.config.productionTip = false

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app')
