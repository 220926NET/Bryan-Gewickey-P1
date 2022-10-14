using Microsoft.Data.SqlClient;

namespace UI;

public class MainMenu
{
    private TicketService _service;

    public MainMenu(TicketService service)
    {
        _service = service;
    }
}
