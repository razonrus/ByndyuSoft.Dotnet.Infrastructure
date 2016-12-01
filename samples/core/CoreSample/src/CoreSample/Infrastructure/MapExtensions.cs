﻿using System.Collections.Generic;
using AutoMapper;

namespace CoreSample.Infrastructure
{
    public static class MapExtensions
    {
        public static TDest MapTo<TDest>(this object source)
        {
            return (TDest)Mapper.Map(source, source.GetType(), typeof(TDest));
        }

        public static TDest MapTo<TDest, TSource>(this TSource source, TDest destination)
        {
            return Mapper.Map(source, destination);
        }

        public static IEnumerable<TDest> MapEachTo<TDest>(this IEnumerable<object> source)
        {
            return source.MapTo<IEnumerable<TDest>>();
        }
    }
}