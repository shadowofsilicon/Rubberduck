﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Rubberduck.Parsing;
using Rubberduck.Parsing.Annotations;
using Rubberduck.Parsing.Symbols;
using Rubberduck.VBEditor;
using Rubberduck.Interaction.Navigation;

namespace Rubberduck.UnitTesting
{
    [SuppressMessage("ReSharper", "ExplicitCallerInfoArgument")]
    public class TestMethod : IEquatable<TestMethod>, INavigateSource
    {
        public TestMethod(Declaration declaration)
        {
            Declaration = declaration;
        }
        public Declaration Declaration { get; }

        public TestCategory Category
        {
            get
            {
                var testMethodAnnotation = (TestMethodAnnotation) Declaration.Annotations
                    .First(annotation => annotation.AnnotationType == AnnotationType.TestMethod);

                return new TestCategory(testMethodAnnotation.Category);
            }
        }

        public NavigateCodeEventArgs GetNavigationArgs()
        {
            return new NavigateCodeEventArgs(new QualifiedSelection(Declaration.QualifiedName.QualifiedModuleName, Declaration.Context.GetSelection()));
        }

        public bool Equals(TestMethod other) => other != null && Declaration.QualifiedName.Equals(other.Declaration.QualifiedName);
        public override bool Equals(object obj) => obj is TestMethod method && Equals(method);
        public override int GetHashCode() => Declaration.QualifiedName.GetHashCode();
    }
}