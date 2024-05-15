using Valve.VR;

namespace EasyOpenVR.Extensions;

public static class HmdVector3_Extensions
{
    public static HmdVector3_t Multiply(this HmdVector3_t vec, float val)
    {
        return new HmdVector3_t
        {
            v0 = vec.v0 * val,
            v1 = vec.v1 * val,
            v2 = vec.v2 * val
        };
    }
}