<template lang="pug">
.home
  .bg-white.rounded.m-4.p-4
    h1 Find a freelancer or find work
</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator'
// import firebase from '@/db'
// const db = firebase.firestore().collection('/tutorials')

@Component({
  components: {

  }
})
export default class Home extends Vue {
  // tutorials: any

  async mounted (): Promise<void> {
    // console.log('CHeck', (await db.get()).docs.map(item => item.data()))
  }

  // create (): void {
  //   db.add({
  //     title: 'New Tutorial',
  //     description: 'Something dark side',
  //     published: Date.now()
  //   })
  // }
}
</script>
