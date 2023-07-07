namespace ChainofResponsibility
{
    class DialogHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Show Dialog")
            {
                return $"Dialog Module: I'll perform '{request.ToString()}' task.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
