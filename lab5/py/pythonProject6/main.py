from classes import TVector2d, TVector3d

vec2dList = [
    TVector2d([3, 1]),
    TVector2d([6, 2]),
    TVector2d([-1, 5])
]

vec3dList = [
    TVector3d([10, 5, -3]),
    TVector3d([3, 8, 12]),
    TVector3d([-6, 1, 6]),
    TVector3d([-1, 2, 0])
]

sumVec2 = 0

for i in range(1, len(vec2dList)):
    if vec2dList[0].is_parallel(vec2dList[i]):
        sumVec2 = sumVec2 + vec2dList[i].vec_length()
print("Sum of parallel 2d vectors lengths: {0}".format(sumVec2))


sumVec3 = 0

for i in range(1, len(vec3dList)):
    if vec3dList[0].is_perpendicular(vec3dList[i]):
        sumVec3 = sumVec3 + vec3dList[i].vec_length()
print("Sum of perpendicular 3d vectors lengths: {0}".format(sumVec3))
