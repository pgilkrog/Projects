<template lang="pug">
.login
  .rounded.p-4.m-4.bg-white
    template(v-if="formView === 1")
      b-form(@submit="login()")
        b-form-input(
          required
          type="email"
          placeholder="Email"
          v-model="form.email"
        )
        b-form-input.mt-2(
          required
          type="password"
          placeholder="Password"
          v-model="form.password"
        )
        b-button.mt-2(type="submit") Login
        .d-flex.mt-4
          p not a user yet?
          p.ml-2.text-primary(v-on:click="formView = 2") create here
    template(v-else)
      b-form(@submit="signup()")
        b-form-input(
          required
          type="email"
          placeholder="Email"
          v-model="form.email"
        )
        b-form-input.mt-2(
          required
          type="password"
          placeholder="Password"
          v-model="form.password"
        )
        b-form-input.mt-2(
          required
          type="password"
          placeholder="Password"
          v-model="form.password2"
        )
        b-button.mt-2(
          type="submit"
          :disabled="form.password !== form.password2"
          variant="primary"
        ) Create
        .d-flex.mt-4
          p(v-on:click="formView = 1") back to login
</template>
<script lang="ts">
import { Component, Vue } from 'vue-property-decorator'
import { AuthModule } from '@/store/AuthModule'

@Component({
  components: {
  }
})

export default class Login extends Vue {
  formView = 1

  form = {
    email: '',
    password: '',
    password2: ''
  }

  // Methods
  login (): void {
    AuthModule.loginUser(this.form)
  }

  signup (): void {
    AuthModule.createUser(this.form)
  }
}
</script>
