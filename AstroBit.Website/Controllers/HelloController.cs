using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Http;
using AstroBit.AstroMath;
using AstroBit.HumanDesign;

namespace AstroBit.Website.Controllers
{
    public class HelloController : ApiController
    {
        public IEnumerable<string> Get()
        {
            //var date = new DateTime(1977, 8, 30, 5, 10, 0, DateTimeKind.Utc); // Martin
            var date = DateTime.Now.ToUniversalTime();

            var ephemeris = new Ephemeris();
            var entry = ephemeris.Get(date);

            var humanDesignGates = new HumanDesignGates();

            // var sunGate = humanDesignGates.GetDefinedGate((entry.Sun.AbsolutePosition - 88.0).Truncate(360));
            var sunGate = humanDesignGates.GetDefinedGate(entry.Sun.AbsolutePosition);
            var earthGate = sunGate.GetOppositeGate();

            yield return "Sun: " + sunGate;
            yield return "Earth: " + earthGate;
            yield return "Moon: " + humanDesignGates.GetDefinedGate(entry.Moon.AbsolutePosition);
            yield return "North Node: " + humanDesignGates.GetDefinedGate(entry.TrueNode.AbsolutePosition);
            yield return "South Node: " + humanDesignGates.GetDefinedGate((entry.TrueNode.AbsolutePosition + 180.0).Truncate(360));
            yield return "Mercury: " + humanDesignGates.GetDefinedGate(entry.Mercury.AbsolutePosition);
            yield return "Venus: " + humanDesignGates.GetDefinedGate(entry.Venus.AbsolutePosition);
            yield return "Mars: " + humanDesignGates.GetDefinedGate(entry.Mars.AbsolutePosition);
            yield return "Jupiter: " + humanDesignGates.GetDefinedGate(entry.Jupiter.AbsolutePosition);
            yield return "Saturn: " + humanDesignGates.GetDefinedGate(entry.Saturn.AbsolutePosition);
            yield return "Uranus: " + humanDesignGates.GetDefinedGate(entry.Uranus.AbsolutePosition);
            yield return "Neptune: " + humanDesignGates.GetDefinedGate(entry.Neptune.AbsolutePosition);
            yield return "Pluto: " + humanDesignGates.GetDefinedGate(entry.Pluto.AbsolutePosition);
        }
    }
}
