namespace ServiceCollectionLab
{
    class B : BaseInformation
    {
        A dependency;
        public B(A dependency)
        {
            this.dependency = dependency;
            NotifyCreate();
        }
    }
}
