--Byte Size of one color unit
function size()
	return 2;
end

--Unpack 1 Color
function unpack(data)
	--little endian
	local t = data[0] + (data[1] * 0x100);

	local r = ((t >> 0) & 0x1F) / 0x1F * 255;
	local g = ((t >> 5) & 0x1F) / 0x1F * 255;
	local b = ((t >> 10) & 0x1F) / 0x1F * 255;
	local a = 255;

	local p = { r, g, b, a };
	return p;
end

--Repack 1 Color
function repack(r,g,b,a)
	--little endian
	local t = 0;
	t = t + ((r / 255 * 0x1F) << 0);
	t = t + ((g / 255 * 0x1F) << 5);
	t = t + ((b / 255 * 0x1F) << 10);
	
	local p = { t & 0xFF, (t >> 8) & 0xFF }
	return p;
end
