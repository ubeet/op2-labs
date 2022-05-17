import abc
import math

class TVector:
    vectorCords = []

    def __init__(self, cords):
        self.vectorCords = cords

    @abc.abstractmethod
    def is_parallel(self, vector):
        pass

    @abc.abstractmethod
    def is_perpendicular(self, vector):
        pass

    @abc.abstractmethod
    def vec_length(self):
        pass


class TVector2d(TVector):
    def is_parallel(self, vector):
        v = self.vectorCords[0] / vector.vectorCords[0] == self.vectorCords[1] / vector.vectorCords[1]
        return v

    def is_perpendicular(self, vector):
        v = self.vectorCords[0] * vector.vectorCords[0] + self.vectorCords[1] * vector.vectorCords[1]
        return v == 0

    def vec_length(self):
        length = math.sqrt(self.vectorCords[0] * self.vectorCords[0] + self.vectorCords[1] * self.vectorCords[1])
        return length


class TVector3d(TVector):
    def is_parallel(self, vector):
        v = self.vectorCords[0] / vector.vectorCords[0] == self.vectorCords[1] / vector.vectorCords[1] and self.vectorCords[2] / vector.vectorCords[2] == self.vectorCords[1] / vector.vectorCords[1]
        return v

    def is_perpendicular(self, vector):
        v = self.vectorCords[0] * vector.vectorCords[0] + self.vectorCords[1] * vector.vectorCords[1] + self.vectorCords[2] * vector.vectorCords[2]
        return v == 0

    def vec_length(self):
        length = math.sqrt(self.vectorCords[0] * self.vectorCords[0] + self.vectorCords[1] * self.vectorCords[1] + self.vectorCords[2] * self.vectorCords[2])
        return length
