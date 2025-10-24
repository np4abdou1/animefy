import { onRequestOptions as __api_anime_store_url_ts_onRequestOptions } from "C:\\Users\\abdou\\Documents\\Anime Website\\next js\\animefy\\functions\\api\\anime\\store-url.ts"
import { onRequestPost as __api_anime_store_url_ts_onRequestPost } from "C:\\Users\\abdou\\Documents\\Anime Website\\next js\\animefy\\functions\\api\\anime\\store-url.ts"
import { onRequestOptions as __api_anime__slug__ts_onRequestOptions } from "C:\\Users\\abdou\\Documents\\Anime Website\\next js\\animefy\\functions\\api\\anime\\[slug].ts"
import { onRequest as __api_anime__slug__ts_onRequest } from "C:\\Users\\abdou\\Documents\\Anime Website\\next js\\animefy\\functions\\api\\anime\\[slug].ts"

export const routes = [
    {
      routePath: "/api/anime/store-url",
      mountPath: "/api/anime",
      method: "OPTIONS",
      middlewares: [],
      modules: [__api_anime_store_url_ts_onRequestOptions],
    },
  {
      routePath: "/api/anime/store-url",
      mountPath: "/api/anime",
      method: "POST",
      middlewares: [],
      modules: [__api_anime_store_url_ts_onRequestPost],
    },
  {
      routePath: "/api/anime/:slug",
      mountPath: "/api/anime",
      method: "OPTIONS",
      middlewares: [],
      modules: [__api_anime__slug__ts_onRequestOptions],
    },
  {
      routePath: "/api/anime/:slug",
      mountPath: "/api/anime",
      method: "",
      middlewares: [],
      modules: [__api_anime__slug__ts_onRequest],
    },
  ]