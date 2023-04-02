from fastapi import APIRouter
import numpy

router = APIRouter()


@router.get('')
def multiply_matrices() -> dict:
    matrix_a = numpy.random.rand(10, 10).tolist()
    matrix_b = numpy.random.rand(10, 10).tolist()
    product = numpy.dot(matrix_a, matrix_b).tolist()
    result = {"matrix_a": matrix_a, "matrix_b": matrix_b, "product": product}
    return result
