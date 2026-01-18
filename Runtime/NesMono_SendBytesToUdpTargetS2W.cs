using System;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.Events;
namespace Eloi.NesUtility
{

    public class NesMono_SendBytesToUdpTargetS2W : MonoBehaviour
    {
        [Tooltip("Target IPv4 address to send UDP packets to.")]
        public string m_targetIpv4;
        [Tooltip("Target port to send UDP packets to.")]
        public int m_targetPort;
        [Tooltip("Player index to be on the target client")]
        public int m_playerDefaultIndex = 0;


        public byte[] m_sendToDebug;

        [Header("Debug")]
        public string m_lastException;

        public UnityEvent<int> m_onIntegerValueSent;
        public UnityEvent<int,int> m_onIndexValueIntegerSent;


        public void SetPlayerIndex(int index)
        {
            m_playerDefaultIndex = index;
        }
        public void SetPlayerIndex(string index)
        {
            if (int.TryParse(index, out int result))
            {
                m_playerDefaultIndex = result;
            }
            else m_playerDefaultIndex = 0;
        }
        public void SetTargetIp(string ip)
        {
            m_targetIpv4 = ip;
        }
        public void SetTargetPort(int port)
        {
            m_targetPort = port;
        }
        public void SetTargetPort(string port)
        {

            if (int.TryParse(port, out int result))
            {
                m_targetPort = result;
            }
            else m_targetPort = 0;
        }

        public void SendBytesTo(string ip, int port, byte[] sendBytes)
        {
            if (sendBytes == null || sendBytes.Length == 0)
                return;

            try
            {
                using (var client = new UdpClient())
                {
                    m_sendToDebug = sendBytes;
                    client.Send(sendBytes, sendBytes.Length, ip, port);
                }
            }
            catch (SocketException e)
            {
                m_lastException = e.ToString();
            }
        }

        public void SendBytesToUdpTarget(byte[] bytes)
        {
            SendBytesTo(m_targetIpv4, m_targetPort, bytes);
        }
        public void SendIntegerToUdpTarget(int intValue)
        {
            byte[] bytes = BitConverter.GetBytes(intValue);
            SendBytesTo(m_targetIpv4, m_targetPort, bytes);
            m_onIntegerValueSent?.Invoke(intValue);
        }
        public void SendIndexIntegerToUdpTarget(int intValue)
        {
            SendIndexIntegerToUdpTarget(m_playerDefaultIndex, intValue);
        }
        public void SendIndexIntegerToUdpTarget(int index, int intValue)
        {
            byte[] doubleInt = new byte[8];
            byte[] first = BitConverter.GetBytes(index);
            byte[] second = BitConverter.GetBytes(intValue);
            Buffer.BlockCopy(first, 0, doubleInt, 0, 4);
            Buffer.BlockCopy(second, 0, doubleInt, 4, 4);
            SendBytesTo(m_targetIpv4, m_targetPort, doubleInt);
            m_onIntegerValueSent?.Invoke(intValue);
            m_onIndexValueIntegerSent?.Invoke(index, intValue);
        }


    }
}