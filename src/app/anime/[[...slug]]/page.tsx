export const dynamic = 'force-dynamic'

import { notFound, redirect } from 'next/navigation';
import { headers } from 'next/headers';

export default async function CatchAllAnimePage() {
  const headersList = await headers();
  const pathname = headersList.get('x-pathname') || '';
  
  console.log('CatchAllAnimePage - Pathname:', pathname);
  
  // Extract slug from pathname
  const pathSegments = pathname.split('/');
  const slugIndex = pathSegments.indexOf('anime');
  
  if (slugIndex === -1 || slugIndex + 1 >= pathSegments.length) {
    console.error('CatchAllAnimePage - Invalid pathname:', pathname);
    notFound();
  }
  
  const slug = pathSegments[slugIndex + 1];
  
  if (!slug) {
    console.error('CatchAllAnimePage - No slug found in pathname:', pathname);
    notFound();
  }
  
  // Redirect to the main anime page with the slug
  const redirectUrl = `/anime/${slug}`;
  console.log('CatchAllAnimePage - Redirecting to:', redirectUrl);
  
  redirect(redirectUrl);
}
