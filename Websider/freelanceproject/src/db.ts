import firebase from 'firebase/compat/app'
import 'firebase/compat/auth'
import 'firebase/compat/firestore'

import { UserModule } from '@/store/UserModule'

const firebaseConfig = {
  apiKey: 'AIzaSyCz7OM_wuYUbNI9GA4ukqWTbm4vlXp9HUY',
  authDomain: 'freelanceproject-6ecaf.firebaseapp.com',
  projectId: 'freelanceproject-6ecaf',
  storageBucket: 'freelanceproject-6ecaf.appspot.com',
  messagingSenderId: '820922416357',
  appId: '1:820922416357:web:7c44ff1da538bfd0b6680c'
}

const firebaseApp = firebase.initializeApp(firebaseConfig)

firebaseApp.auth().onAuthStateChanged(user => {
  UserModule.getUserInfo(user?.uid)
})

export default firebaseApp
