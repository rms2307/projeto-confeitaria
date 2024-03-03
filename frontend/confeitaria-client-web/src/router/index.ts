import Ingrediente from "@/pages/IngredientePage.vue"
import Home from "@/pages/HomePage.vue"
import { createRouter, createWebHistory } from "vue-router"

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: "/",
      name: "home",
      component: Home,
    },
    {
      path: "/ingredientes",
      name: "ingredientes",
      component: Ingrediente,
    },
  ],
})

export default router
