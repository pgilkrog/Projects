<template lang="pug">
.app.d-flex
  NavMenu
  router-view
</template>
<script lang="ts">
import { Component, Vue } from 'vue-property-decorator'
import NavMenu from '@/components/NavMenu.vue'
import { UserModule } from '@/store/UserModule'

@Component({
  components: {
    NavMenu
  }
})
export default class App extends Vue {
  async mounted (): Promise<void> {
    await UserModule.init()
  }
}
</script>
