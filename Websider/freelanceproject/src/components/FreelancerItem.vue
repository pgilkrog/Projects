<template lang="pug">
.freelancer-item.pointer(v-on:click="goToDetails()")
  .bg-white.rounded-top.p-4
    .d-flex
      b-avatar(:src="freelancer.image" size="8rem")
      span.ml-4
        h2 {{ freelancer.name }}
        h4 {{ freelancer.title }}
    .freelancer-description.mt-2 {{ freelancer.description }}
  .bg-primary.bg-gradient.rounded-bottom.p-2.d-flex.justify-content-end
    b-icon(icon="linkedin" variant="dark" font-scale="2")
    b-icon.ml-2(icon="github" variant="dark" font-scale="2")
    b-icon.ml-2(icon="globe" variant="dark" font-scale="2")
</template>

<script lang="ts">
import { IUserData } from '@/types/UserTypes'
import { Component, Vue } from 'vue-property-decorator'
import router from '@/router'

@Component({
  props: {
    freelancer: Object
  }
})
export default class FreelancerItem extends Vue {
  freelancer!: IUserData

  goToDetails (): void {
    router.push('/profile/' + this.freelancer.userId)
  }
}
</script>
