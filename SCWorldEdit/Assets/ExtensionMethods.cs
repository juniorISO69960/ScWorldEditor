﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SCWorldEdit.Assets
{

    public static class DbContextExtensions
    {

        //This gives you nicer syntax to raise the event ...
        //MyEvent.Raise( this, new MyEventArgs() );

        public static void Raise<T>(this EventHandler<T> argHandler, object argSender, T argEvt) where T : EventArgs
        {
            if (argHandler != null) argHandler(argSender, argEvt);
        }

        public static void Raise(this EventHandler argHandler, object argSender, EventArgs argEvt)
        {
            if (argHandler != null) argHandler(argSender, argEvt);
        }

        public static void Raise(this EventHandler argHandler, object argSender)
        {
            if (argHandler != null) argHandler(argSender, EventArgs.Empty);
        }

        /**********************************************************************************************************************/

        //// get MaxLength as an extension method to the DbContext
        //public static int? GetMaxLength<T>(this DbContext context, Expression<Func<T, string>> column)
        //{
        //    return (int?)context.GetFacets<T>(column)["MaxLength"].Value;
        //}

        //// get MaxLength as an extension method to the Facets (I think the extension belongs here)
        //public static int? GetMaxLength(this ReadOnlyMetadataCollection<Facet> facets)
        //{
        //    return (int?)facets["MaxLength"].Value;
        //}

        //// just for fun: get all the facet values as a Dictionary 
        //public static Dictionary<string, object> AsDictionary(this ReadOnlyMetadataCollection<Facet> facets)
        //{
        //    return facets.ToDictionary(o => o.Name, o => o.Value);
        //}


        //public static ReadOnlyMetadataCollection<Facet> GetFacets<T>(this DbContext context, Expression<Func<T, string>> column)
        //{
        //    ReadOnlyMetadataCollection<Facet> result = null;

        //    var entType = typeof(T);
        //    var columnName = ((MemberExpression)column.Body).Member.Name;

        //    var objectContext = ((IObjectContextAdapter)context).ObjectContext;
        //    var test = objectContext.MetadataWorkspace.GetItems(DataSpace.CSpace);

        //    if (test == null)
        //        return null;

        //    var q = test
        //        .Where(m => m.BuiltInTypeKind == BuiltInTypeKind.EntityType)
        //        .SelectMany(meta => ((EntityType)meta).Properties
        //        .Where(p => p.Name == columnName && p.TypeUsage.EdmType.Name == "String"));

        //    var queryResult = q.Where(p =>
        //    {
        //        var match = p.DeclaringType.Name == entType.Name;
        //        if (!match)
        //            match = entType.Name == p.DeclaringType.Name;

        //        return match;

        //    })
        //        .Select(sel => sel)
        //        .FirstOrDefault();

        //    result = queryResult.TypeUsage.Facets;

        //    return result;

        //}

    }
}
