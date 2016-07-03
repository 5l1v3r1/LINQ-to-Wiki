﻿using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using LinqToWiki.Collections;
// <copyright file="TupleListT1T2Test.ItemGet.g.cs">Copyright ©  2011</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace LinqToWiki.Collections.Tests
{
    public partial class TupleListT1T2Test
    {

[TestMethod]
[PexGeneratedBy(typeof(TupleListT1T2Test))]
[ExpectedException(typeof(InvalidOperationException))]
public void ItemGetThrowsInvalidOperationException335()
{
    TupleList<int, int> tupleList;
    int i;
    Tuple<int, int>[] tuples = new Tuple<int, int>[2];
    tupleList = TupleListFactory.Create((IEnumerable<Tuple<int, int>>)tuples);
    i = this.ItemGet<int, int>(tupleList, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(TupleListT1T2Test))]
[ExpectedException(typeof(InvalidOperationException))]
public void ItemGetThrowsInvalidOperationException331()
{
    TupleList<int, int> tupleList;
    int i;
    Tuple<int, int>[] tuples = new Tuple<int, int>[0];
    tupleList = TupleListFactory.Create((IEnumerable<Tuple<int, int>>)tuples);
    i = this.ItemGet<int, int>(tupleList, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(TupleListT1T2Test))]
[ExpectedException(typeof(InvalidOperationException))]
public void ItemGetThrowsInvalidOperationException754()
{
    TupleList<int, int> tupleList;
    int i;
    Tuple<int, int>[] tuples = new Tuple<int, int>[1];
    tupleList = TupleListFactory.Create((IEnumerable<Tuple<int, int>>)tuples);
    i = this.ItemGet<int, int>(tupleList, 0);
}
    }
}
