export interface IUserState {
  _initialized: boolean
}

export interface Rating {
  freelanceId: string,
  userId: string,
  rating: number,
  description: string
  dateCreated: Date
}

export interface Company {
  name: string,
  email: string,
  phone: string
}

export interface IUserData {
  userId: string
  name: string
  title: string
  phone: string
  rating: number
  ratingAmount: number
  website: string
  description: string
  skills: string[]
  image: string
  ratings: Rating[]
}

export interface ILoginInfo {
  email: string
  password: string
  password2: string
}
