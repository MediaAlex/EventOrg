﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace EventOrg
{
    public class Eventart
    {
        public string idEA { get; set; }
        public string nameEA { get; set; }
        public bool aktivEA { get; set; }
        public List<ListInfo> listInfo { get; set; }
        
    }
}
