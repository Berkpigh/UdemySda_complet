import { useDispatch, useSelector } from "react-redux"
import { decrement, incrementAsync } from "../../../../redux/counter/counterSlice";
import { AppDispatch, RootState } from "../../../../redux/storeRedux";

export const Counter = () => {
  const count = useSelector((state: RootState) => state.counter.value);
  const dispatch = useDispatch<AppDispatch>();

  return (
    <>
      <div>
            <h2>{count}</h2>
            <div>
                <button onClick={() => dispatch(incrementAsync(10))}>Increment</button>
                <button onClick={() => dispatch(decrement())}>Decrement</button>
            </div>
      </div>
    </>
  );
};
