<template lang="pug">
.profile
  template(v-if="userData !== undefined")
    h1 {{ userData.userId }}
    h2 {{ userData.name }}
</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator'
import { UserModule } from '@/store/UserModule'
import { IUserData } from '@/types/UserTypes'

@Component({
  components: {

  }
})

export default class Profile extends Vue {
  userData = UserModule.userData as IUserData

  mounted (): void {
    if (this.$route.params.id !== 'undefined') {
      this.userData = UserModule.users?.find(item => item.userId.toString() === this.$route.params.id) as IUserData
    } else {
      this.userData = UserModule.userData as IUserData
    }
  }

  get isUserloggedIn (): boolean {
    return UserModule.isLoggedIn
  }
}
</script>
