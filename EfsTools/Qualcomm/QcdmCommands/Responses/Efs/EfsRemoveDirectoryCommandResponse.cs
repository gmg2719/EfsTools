﻿using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Resourses;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.Efs
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort)QcdmEfsCommand.Rmdir)]
    [QcdmMinResponseLength(8)]
    internal class EfsRemoveDirectoryCommandResponse : BaseSubSystemCommandResponse
    {
        private EfsRemoveDirectoryCommandResponse()
        {
        }

        public static EfsRemoveDirectoryCommandResponse Parse(byte[] data)
        {
            var result = new EfsRemoveDirectoryCommandResponse();
            result.CheckResponse(data);
            var error = (QcdmEfsErrors) BitConverter.ToInt32(data, 4);
            result.Error = error;
            return result;
        }

        public QcdmEfsErrors Error { get; private set; }
    }
}