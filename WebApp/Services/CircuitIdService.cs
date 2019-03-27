namespace WebApp.Services
{
    using System;

    public class CircuitIdService
    {
        public Guid Id { get; } = Guid.NewGuid();
    }
}
