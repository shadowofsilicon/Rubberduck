using System;

namespace Rubberduck.VBEditor
{
    public readonly struct QualifiedSelection : IComparable, IComparable<QualifiedSelection>, IEquatable<QualifiedSelection>
    {
        public QualifiedSelection(QualifiedModuleName qualifiedName, Selection selection)
        {
            QualifiedName = qualifiedName;
            Selection = selection;
        }

        public QualifiedModuleName QualifiedName { get; }

        public Selection Selection { get; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            QualifiedSelection other = (QualifiedSelection)obj;

            if (other != null)
                return this.CompareTo(other);
            else
                throw new ArgumentException("Object is not a QualifiedSelection");
        }

        public int CompareTo(QualifiedSelection other)
        {
            return other.QualifiedName == QualifiedName
                ? Selection.CompareTo(other.Selection)
                : string.Compare(QualifiedName.ToString(), other.QualifiedName.ToString(), StringComparison.CurrentCultureIgnoreCase);
        }

        public bool Equals(QualifiedSelection other)
        {
            return other.Selection.Equals(Selection) && other.QualifiedName.Equals(QualifiedName);
        }

        public override string ToString()
        {
            return $"{QualifiedName} {Selection}";
        }

        public override int GetHashCode()
        {
            return HashCode.Compute(QualifiedName.GetHashCode(), Selection.GetHashCode());
        }

        public static bool operator ==(QualifiedSelection selection1, QualifiedSelection selection2)
        {
            return selection1.Equals(selection2);
        }

        public static bool operator !=(QualifiedSelection selection1, QualifiedSelection selection2)
        {
            return !(selection1 == selection2);
        }

        public override bool Equals(object obj)
        {
            if (obj is QualifiedSelection qualifiedSelection)
            {
                return Equals(qualifiedSelection);
            }
            return false;
        }
    }
}
