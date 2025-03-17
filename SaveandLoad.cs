using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace DSplit;
public class RunData
{
    public string Game { get; set; }
    public int RunCount { get; set; }
    public List<SegmentData> Segment { get; set; }
}

public class SegmentData
{
    public string SegmentName { get; set; }
    public TimeSpan SplitTime { get; set; }
}
