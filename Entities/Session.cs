using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities;

public class Session
{
    public int Id { get; set; }

    public int RoomNumber { get; set; }

    public DateTime DateTime { get; set; }

    public Movie? MovieToShow { get; set; }
}
