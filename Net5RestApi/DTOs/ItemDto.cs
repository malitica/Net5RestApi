using System;

namespace Net5RestApi.DTOs
{
    public record ItemDto
    {
            public Guid Id { get; init; }
            public string Name { get; init; }
            public decimal Price { get; init; }
            public DateTimeOffset CreatedDate { get; init; }       
    }
}
