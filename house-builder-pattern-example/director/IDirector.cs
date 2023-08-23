using house_builder_pattern_example.builder;
using house_builder_pattern_example.structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house_builder_pattern_example.director
{
    public interface IDirector
    {
        Structure Instruct(IBuilder builder);
    }
}
