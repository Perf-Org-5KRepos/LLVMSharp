﻿namespace LLVMSharp
{
    using System;

    public partial struct LLVMSectionIteratorRef : IEquatable<LLVMSectionIteratorRef>, IHandle<SectionIterator>
    {
        public IntPtr GetInternalPointer() => Pointer;

        public bool Equals(LLVMSectionIteratorRef other)
        {
            return this.Pointer == other.Pointer;
        }

        SectionIterator IHandle<SectionIterator>.ToWrapperType()
        {
            return new SectionIterator(this);
        }

        public override bool Equals(object obj)
        {
            if (obj is LLVMSectionIteratorRef)
            {
                return this.Equals((LLVMSectionIteratorRef)obj);
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(LLVMSectionIteratorRef op1, LLVMSectionIteratorRef op2)
        {
            return op1.Equals(op2);
        }

        public static bool operator !=(LLVMSectionIteratorRef op1, LLVMSectionIteratorRef op2)
        {
            return !(op1 == op2);
        }

        public override int GetHashCode()
        {
            return this.Pointer.GetHashCode();
        }
    }
}
