import Ingredientes from "@/pages/Ingredientes.vue"
import Home from "@/pages/Home.vue"
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
      component: Ingredientes,
    },
  ],
})

export default router
