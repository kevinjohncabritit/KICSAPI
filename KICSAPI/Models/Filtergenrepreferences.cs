﻿using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Filtergenrepreferences
    {
        public int FilterGenrePreferenceId { get; set; }
        public Guid FilterId { get; set; }
        public short GenreId { get; set; }

        public Filter Filter { get; set; }
        public Genre Genre { get; set; }
    }
}
