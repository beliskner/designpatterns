using System;
using System.Collections.Generic;
using System.Text;

namespace DPW2A1
{
    public abstract class BigDataLoader
    {
        public abstract void ExtractData();
        public abstract void TransformData();
        public abstract void LoadData();
    }
}
