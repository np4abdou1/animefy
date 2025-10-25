export const runtime = 'edge'
export const dynamic = 'force-dynamic'

import { notFound, redirect } from 'next/navigation';
import { headers } from 'next/headers';

export default async function FallbackPage() {
  const headersList = await headers();
  const pathname = headersList.get('x-pathname') || '';
  
  console.log('FallbackPage - Pathname:', pathname);
  
  // Extract slug from pathname
  const pathSegments = pathname.split('/');
  const slugIndex = pathSegments.indexOf('anime');
  
  if (slugIndex === -1 || slugIndex + 1 >= pathSegments.length) {
    console.error('FallbackPage - Invalid pathname:', pathname);
    notFound();
  }
  
  const slug = pathSegments[slugIndex + 1];
  
  if (!slug) {
    console.error('FallbackPage - No slug found in pathname:', pathname);
    notFound();
  }
  
  // Redirect to the main anime page
  const redirectUrl = `/anime/${slug}`;
  console.log('FallbackPage - Redirecting to:', redirectUrl);
  
  redirect(redirectUrl);
}
