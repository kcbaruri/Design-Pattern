namespace ChainofResponsibility
{
    class ParameterHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Set Parameters")
            {
                return $"Parameter Module: I'll perform '{request.ToString()}' task.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
