using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Enums
{
    public enum LiquidationReason
    {
        Lost,
        Damaged,
        LostByUser
    }

    public static class LiquidationReasonExtensions
    {
        public static string GetDisplayName(this LiquidationReason reason)
        {
            switch (reason)
            {
                case LiquidationReason.Lost:
                    return "Mất";
                case LiquidationReason.Damaged:
                    return "Hỏng";
                case LiquidationReason.LostByUser:
                    return "Mất do người dùng";
                default:
                    return reason.ToString();
            }
        }

        public static string ToDbValue(this LiquidationReason reason)
        {
            return reason.GetDisplayName();
        }
    }
}
