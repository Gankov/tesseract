﻿using System;

namespace Tesseract
{
    public sealed class ResultIterator : PageIterator
    {
        internal ResultIterator(IntPtr handle)
            : base(handle)
        {
        }

        public float GetConfidence(PageIteratorLevel level)
        {
            return Interop.TessApi.ResultIteratorGetConfidence(handle, level);
        }

        public string GetText(PageIteratorLevel level)
        {
            return Interop.TessApi.ResultIteratorGetUTF8Text(handle, level);
        }
        
        /// <summary>
		/// Gets the copy of iterator.
		/// </summary>
		public new ResultIterator Clone()
		{
			return new ResultIterator(Interop.TessApi.ResultIteratorCopy (handle));
		}
    }
}
