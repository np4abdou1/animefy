'use client'

import { useEffect } from 'react'

export default function Error({
  error,
  reset,
}: {
  error: Error & { digest?: string }
  reset: () => void
}) {
  useEffect(() => {
    console.error('Anime page error:', error)
  }, [error])

  return (
    <div className="min-h-screen bg-black text-white flex items-center justify-center">
      <div className="text-center max-w-md mx-auto px-4">
        <h2 className="text-2xl font-bold mb-4">حدث خطأ في تحميل الأنمي</h2>
        <p className="text-gray-400 mb-6">
          عذراً، حدث خطأ أثناء تحميل بيانات الأنمي. يرجى المحاولة مرة أخرى.
        </p>
        <button
          onClick={reset}
          className="bg-blue-600 hover:bg-blue-700 text-white px-6 py-2 rounded-lg transition-colors"
        >
          المحاولة مرة أخرى
        </button>
      </div>
    </div>
  )
}
