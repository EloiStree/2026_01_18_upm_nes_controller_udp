import socket
import struct

def listen_udp():
    sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
    sock.bind(("0.0.0.0", 7073))
    
    print("Listening on 0.0.0.0:7073...")
    
    while True:
        data, addr = sock.recvfrom(1024)
        print(f"Received from {addr}: {data}")
        
        if len(data) == 8:
            int1, int2 = struct.unpack('<ii', data)
            print(f"  Parsed as two integers: {int1}, {int2}")
        if len(data) == 4:
            int1= struct.unpack('<i', data)[0]
            print(f"  Parsed as one integer: {int1}")

if __name__ == "__main__":
    listen_udp()