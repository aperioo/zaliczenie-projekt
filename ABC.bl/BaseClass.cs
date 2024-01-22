namespace ABC.bl
{
    public abstract class BaseClass
    {
        public bool IsNew { get; set; }
        public bool IsChanged { get; set; }
        public ObjectStatusOptions ObjectStatus { get; set; }
        public bool IsDataCorrect 
        { 
            get {
                return Validate();
                } 
        }
        public abstract bool Validate();

        public enum ObjectStatusOptions
        {
            Active,
            Inactive
        }
    }
}