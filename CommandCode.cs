using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BERT
{
    public class CommandCode
    {
        /// <summary>
        /// FW側定義エラー
        /// </summary>
        #region FW_CODE
        public const int OK = 0;
        public const int ERROR_NOT_FOUND = 1;
        public const int ERROR_ARG_VALUE = -2;
        public const int ERROR_ARG_COUNT = -3;
        public const int ERROR_I2C_BUS = -10;
        #endregion

        #region GUI定義
        public const int ERROR_FORMAT = -100;
        public const int ERROR_COMM = -101;
        public const int ERROR_DEVICE = -102;
        public const int ERROR_TIMEOUT = -103;
        #endregion
    }
}
