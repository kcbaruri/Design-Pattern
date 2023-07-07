namespace ChainofResponsibility
{
    class PrintHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Print")
            {
                return $"Print Module: I'll perfrom '{request.ToString()}' task.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
