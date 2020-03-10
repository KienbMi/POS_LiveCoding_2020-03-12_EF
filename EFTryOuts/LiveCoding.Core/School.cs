﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LiveCoding.Core
{
  public class School
  {
    public int Id { get; set; }

    public string Principal { get; set; }

    public string Name { get; set; }
    
    public City City { get; set; }

    public Schooltype Schooltype { get; set; }

    public IList<Pupil> Pupils { get; set; }
  }
}
