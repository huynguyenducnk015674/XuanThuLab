namespace ServiceCollectionLab
{
    class C : BaseInformation
    {
        B dependencyB;
        public C(B dependencyB)
        {
            this.dependencyB = dependencyB;
            NotifyCreate();
        }
    }
}
