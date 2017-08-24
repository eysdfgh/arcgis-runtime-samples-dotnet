﻿// Copyright 2016 Esri.
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License.
// You may obtain a copy of the License at: http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an 
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific 
// language governing permissions and limitations under the License.

using Esri.ArcGISRuntime.Data;
using Esri.ArcGISRuntime.Geometry;
using Esri.ArcGISRuntime.Mapping;
using Esri.ArcGISRuntime.Symbology;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace ArcGISRuntime.WPF.Samples.ExportTiles
{
    public partial class ExportTiles
    {

        public ExportTiles()
        {
            InitializeComponent();

            // Call a function to set up the map
            Initialize();
        }

        private void Initialize()
        {
            Map myMap = new Map(Basemap.CreateStreets());
            MyMapView.Map = myMap;
        }

    }
}