using GreatQuotes.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace GreatQuotes.Data
{
    public static class QuoteLoaderFactory
    {
        public static Func<IQuoteLoader> Create { get; set; }
    }
}
