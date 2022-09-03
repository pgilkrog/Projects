<template lang="pug">
.freelancers.w-100
  h1 Freelancers
  template(v-if="freelancers.length > 0")
    .freelancers-wrap.p-4
      FreelancerItem(v-for="(item, index) in freelancers" :key="index" :freelancer="item")

</template>

<script lang="ts">
import { UserModule } from '@/store/UserModule'
import { IUserData } from '@/types/UserTypes'
import { Component, Vue } from 'vue-property-decorator'
import FreelancerItem from '@/components/FreelancerItem.vue'

@Component({
  components: {
    FreelancerItem
  }
})
export default class Freelancers extends Vue {
  freelancers: IUserData[] = []

  mounted (): void {
    if (this.freelancers.length === 0) {
      this.freelancers = UserModule.users !== undefined ? UserModule.users : []
    }
  }
}
</script>
