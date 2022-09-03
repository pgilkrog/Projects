<template lang="pug">
.nav-menu.bg-white.p-4.border-right(style="height: 100vh")
  span
    h2 Freelance Finder
    b-nav(vertical)
      b-nav-item(active to="/")
        b-icon(icon="house")
        | Home
      b-nav-item(to="/freelancers")
        b-icon(icon="person")
        | Find Freelance
      b-nav-item(to="/about")
        b-icon(icon="briefcase")
        | Find work
      b-nav-item(to="/about") About Us
      b-nav-item(to="/about") Contact
  b-nav(vertical)
    b-nav-item(to="/profile/undefined" v-if="isUserloggedIn === true") Profile
    b-nav-item(to="/login" v-if="isUserloggedIn !== true") Login
    b-nav-item(v-on:click="logout()" v-else) logout
</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator'
import { UserModule } from '@/store/UserModule'
import { AuthModule } from '@/store/AuthModule'

@Component({
  components: {
  }
})

export default class NavMenu extends Vue {
  get isUserloggedIn (): boolean {
    return UserModule.isLoggedIn
  }

  logout (): void {
    AuthModule.logoutUser()
    UserModule.setUserInfo(undefined)
  }
}
</script>
