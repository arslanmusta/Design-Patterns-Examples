namespace BuilderPattern.Code
{
    public class CodeBuilder
    {
        private readonly ClassElement _classElement = new ();

        public CodeBuilder(string className)
        {
            _classElement.Name = className;
        }

        public CodeBuilder AddField(string fieldName, string fieldType)
        {
            _classElement.Fields.Add((fieldType, fieldName));

            return this;
        }

        public override string ToString()
        {
            return _classElement.ToString();
        }
    }
}