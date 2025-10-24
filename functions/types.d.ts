// Cloudflare Pages Function types
declare module '@cloudflare/workers-types' {
  export interface KVNamespace {
    get(key: string): Promise<string | null>;
    put(key: string, value: string, options?: any): Promise<void>;
    delete(key: string): Promise<void>;
  }
}

declare type PagesFunction<Env = any> = (context: {
  request: Request;
  env: Env;
  params: Record<string, string>;
  waitUntil: (promise: Promise<any>) => void;
  next: () => Promise<Response>;
}) => Response | Promise<Response>;
