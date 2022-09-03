import { Rating } from './Rating'

export interface Freelancer {
  userId: string
  name: string
  phone: string
  rating: number
  ratingAmount: number
  website: string
  description: string
  skills: string[]
  image: string
  ratings: Rating[]
}
