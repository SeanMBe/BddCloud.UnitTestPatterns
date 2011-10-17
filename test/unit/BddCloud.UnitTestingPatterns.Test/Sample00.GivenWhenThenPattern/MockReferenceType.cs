namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    public class BaseReferenceType
    {
        private readonly int _hashCode;

        public int Id { get; set;}

        public BaseReferenceType(int hashCode)
        {
            _hashCode = hashCode;
        }

        public override bool Equals(object obj)
        {
            var fakeRefType = obj as BaseReferenceType;
            return fakeRefType != null && this.GetHashCode() == fakeRefType.GetHashCode();
        }

        public override int GetHashCode()
        {
            return _hashCode;
        }
    }
}
